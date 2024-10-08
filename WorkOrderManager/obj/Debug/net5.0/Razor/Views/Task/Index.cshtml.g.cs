#pragma checksum "D:\Jagadeesan\DOT NET CORE\WorkOrder\WorkOrderManager\WorkOrderManager\Views\Task\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cadb2a5cf13f6d37a0b88d0ac8478cce63000c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_Index), @"mvc.1.0.view", @"/Views/Task/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Jagadeesan\DOT NET CORE\WorkOrder\WorkOrderManager\WorkOrderManager\Views\_ViewImports.cshtml"
using WorkOrderManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Jagadeesan\DOT NET CORE\WorkOrder\WorkOrderManager\WorkOrderManager\Views\_ViewImports.cshtml"
using WorkOrderManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cadb2a5cf13f6d37a0b88d0ac8478cce63000c5", @"/Views/Task/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05e33b7ca90f8799124ca216cb2c039c87d1869c", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WorkOrderManager.Models.Tasks>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    table {
        width: 100%;
        border-collapse: collapse;
        margin-top: 20px
    }

    table, td, th {
        border: 1px solid #000000;
    }

    td, th {
        padding: 8px;
        text-align: left;
    }

    th {
        background-color: #f2f2f2;
    }
</style>

<h1> Task List</h1>
<button type=""button""");
            BeginWriteAttribute("onclick", " onclick=\"", 407, "\"", 512, 3);
            WriteAttributeValue("", 417, "window.location.href=\'", 417, 22, true);
#nullable restore
#line 25 "D:\Jagadeesan\DOT NET CORE\WorkOrder\WorkOrderManager\WorkOrderManager\Views\Task\Index.cshtml"
WriteAttributeValue("", 439, Url.Action("Create", "Task", new { id = 0, orderID = ViewBag.OrderID }), 439, 72, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 511, "\'", 511, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Add</button>
<table>
    <thead>
        <tr>
            <th>S.No</th>
            <th>OrderNo</th>
            <th>Task No</th>
            <th>Description</th>
            <th>Status</th>
            <th>Carried Out Date</th>
            <th>Journey</th>
            <th></th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 41 "D:\Jagadeesan\DOT NET CORE\WorkOrder\WorkOrderManager\WorkOrderManager\Views\Task\Index.cshtml"
          int row = 0;
            foreach (var item in Model)
            {
                row++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 46 "D:\Jagadeesan\DOT NET CORE\WorkOrder\WorkOrderManager\WorkOrderManager\Views\Task\Index.cshtml"
                   Write(row);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 47 "D:\Jagadeesan\DOT NET CORE\WorkOrder\WorkOrderManager\WorkOrderManager\Views\Task\Index.cshtml"
                   Write(item.OrderNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 48 "D:\Jagadeesan\DOT NET CORE\WorkOrder\WorkOrderManager\WorkOrderManager\Views\Task\Index.cshtml"
                   Write(item.TaskNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "D:\Jagadeesan\DOT NET CORE\WorkOrder\WorkOrderManager\WorkOrderManager\Views\Task\Index.cshtml"
                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td");
            BeginWriteAttribute("style", " style=\"", 1169, "\"", 1238, 2);
            WriteAttributeValue("", 1177, "background-color:", 1177, 17, true);
#nullable restore
#line 50 "D:\Jagadeesan\DOT NET CORE\WorkOrder\WorkOrderManager\WorkOrderManager\Views\Task\Index.cshtml"
WriteAttributeValue(" ", 1194, GetBackgroundColor(item.OrderTaskStatus), 1195, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "D:\Jagadeesan\DOT NET CORE\WorkOrder\WorkOrderManager\WorkOrderManager\Views\Task\Index.cshtml"
                                                                                         Write(item.OrderTaskStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 51 "D:\Jagadeesan\DOT NET CORE\WorkOrder\WorkOrderManager\WorkOrderManager\Views\Task\Index.cshtml"
                    Write(item.CODate.HasValue ? item.CODate.Value.ToString("dd-MM-yyyy") : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 52 "D:\Jagadeesan\DOT NET CORE\WorkOrder\WorkOrderManager\WorkOrderManager\Views\Task\Index.cshtml"
                   Write(item.COJourneyNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1470, "\"", 1541, 1);
#nullable restore
#line 54 "D:\Jagadeesan\DOT NET CORE\WorkOrder\WorkOrderManager\WorkOrderManager\Views\Task\Index.cshtml"
WriteAttributeValue("", 1477, Url.Action("Create", "Task", new { id = item.ID, orderID = 0 }), 1477, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>   |\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1583, "\"", 1641, 1);
#nullable restore
#line 55 "D:\Jagadeesan\DOT NET CORE\WorkOrder\WorkOrderManager\WorkOrderManager\Views\Task\Index.cshtml"
WriteAttributeValue("", 1590, Url.Action("Delete", "Task", new { id = item.ID }), 1590, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 58 "D:\Jagadeesan\DOT NET CORE\WorkOrder\WorkOrderManager\WorkOrderManager\Views\Task\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "D:\Jagadeesan\DOT NET CORE\WorkOrder\WorkOrderManager\WorkOrderManager\Views\Task\Index.cshtml"
            
    private string GetBackgroundColor(string status)
    {
        return status switch
        {
            "Open" => "lightgreen",
            "Planned" => "lightblue",
            "Closed" => "lightgray",
            "Approved" => "lightyellow",
            _ => "white"
        };
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WorkOrderManager.Models.Tasks>> Html { get; private set; }
    }
}
#pragma warning restore 1591
