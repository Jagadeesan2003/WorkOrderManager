using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkOrderManager.Data;
using WorkOrderManager.Models;

namespace WorkOrderManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly WOContext woContext;
        public HomeController(WOContext context)
        {
            this.woContext = context;
        }
        public IActionResult Index()
        {
            var workOrders = woContext.WorkOrder.ToList();
            return View(workOrders);
        }

        public IActionResult Create(int Id)
        {
            if (Id > 0)
            {
                var model = woContext.WorkOrder.FirstOrDefault(w => w.ID == Id);
                if (model != null)
                {
                    return View(model);
                }
            }
            return View();
        }

        [HttpPost]
        public IActionResult Save(WorkOrder data)
        {
            if(data.ID > 0)
            {
                var workOrder = woContext.WorkOrder.Find(data.ID);

                if(workOrder != null)
                {
                    workOrder.OrderNo = data.OrderNo;
                    workOrder.Description = data.Description;
                    workOrder.Reg = data.Reg;
                    workOrder.Model = data.Model;
                    workOrder.SerialNo = data.SerialNo;
                    if (data.OrderStatus == "Closed" && workOrder.OrderStatus !="Closed")
                    {
                        workOrder.ClosedDate = DateTime.UtcNow;
                    }
                    workOrder.OrderStatus = data.OrderStatus;
                }
            }
            else 
            {
                if (data.OrderStatus == "Open" || data.OrderStatus == "Planned" || data.OrderStatus == "Approved")
                {
                    data.OpenDate = DateTime.UtcNow;
                }
                else if (data.OrderStatus == "Closed")
                {
                    data.ClosedDate = DateTime.UtcNow;
                }
                WorkOrder workOrder = new WorkOrder()
                {
                    OrderNo = data.OrderNo,
                    Description = data.Description,
                    Reg = data.Reg,
                    Model = data.Model,
                    SerialNo = data.SerialNo,
                    OrderStatus = data.OrderStatus,
                    OpenDate = data.OpenDate,
                    UserID = 1,
                    GUID = Guid.NewGuid(),
                    CreatedDate = DateTime.UtcNow
                };

                woContext.WorkOrder.Add(workOrder);
            }
            
            woContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            if(Id > 0)
            {
                var model = woContext.WorkOrder.Find(Id);
                if(model != null)
                {
                    var tasks = woContext.Tasks.Where(t => t.OrderID == Id);
                    if(tasks != null)
                    {
                        woContext.Tasks.RemoveRange(tasks);
                    }
                    woContext.WorkOrder.Remove(model);
                    woContext.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
    }
}
