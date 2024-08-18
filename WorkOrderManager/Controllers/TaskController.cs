using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkOrderManager.Data;
using WorkOrderManager.Models;

namespace WorkOrderManager.Controllers
{
    public class TaskController : Controller
    {
        private readonly WOContext woContext;
        public TaskController(WOContext WoContext)
        {
            this.woContext = WoContext;
        }
        public IActionResult Index(int Id)
        {
            ViewBag.OrderID = Id;
            var model = woContext.Tasks.Where(t => t.OrderID == Id).ToList();
            return View(model);
        }

        public IActionResult Create(int Id, int OrderID)
        {
            if(Id > 0)
            {
                var model = woContext.Tasks.Find(Id);
                if(model != null)
                {
                    return View(model);
                }
            }
            Tasks tasks = new Tasks()
            {
                OrderID = OrderID
            };
            return View(tasks);
        }

        public IActionResult Save(Tasks data)
        {
            if(data.ID > 0)
            {
                var tasks = woContext.Tasks.Find(data.ID);
                if(tasks != null)
                {
                    tasks.TaskNo = data.TaskNo;
                    tasks.Description = data.Description;
                    if(data.OrderTaskStatus == "Closed" && tasks.OrderTaskStatus != "Closed")
                    {
                        tasks.CODate = DateTime.UtcNow;
                        tasks.COJourneyNo = "J01";
                    }
                    tasks.OrderTaskStatus = data.OrderTaskStatus;
                    tasks.UpdatedDate = DateTime.UtcNow;
                    tasks.UserID = 1;
                    woContext.SaveChanges();
                    return RedirectToAction("Index", new { Id = tasks.OrderID });
                }
            }
            else
            {
                var order = woContext.WorkOrder.Find(data.OrderID);
                if(order != null)
                {
                    Tasks tasks = new Tasks()
                    {
                        TaskNo = data.TaskNo,
                        OrderID = data.OrderID,
                        OrderNo = order.OrderNo,
                        Description = data.Description,
                        OrderTaskStatus = data.OrderTaskStatus,
                        UserID = 1,
                        GUID = Guid.NewGuid(),
                        UpdatedDate = DateTime.UtcNow
                    };

                    woContext.Tasks.Add(tasks);
                }
            }

            woContext.SaveChanges();
            return RedirectToAction("Index", new { Id = data.OrderID });
        }

        public IActionResult Delete(int Id)
        {
            if(Id > 0)
            {
                var model = woContext.Tasks.Find(Id);
                if(model != null)
                {
                    woContext.Tasks.Remove(model);
                    woContext.SaveChanges();
                    return RedirectToAction("Index", new { Id = model.OrderID });
                }
            }
            return RedirectToAction("Index", new { Id = 0 });
        }
    }
}
