using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        // GET: /<controller>/
       

        [HttpGet("skills")]
        public IActionResult Skills()
        {
            string html = "<h1> Skills Tracker </h1>" +
                          "<h2>Programming Languages</h2>"+
                          "<ol>" +
                          "<li>C#</li>" +
                          "<li>JavaScript</li>" +
                          "<li>Python</li>" +
                          "</ol>";
                
            return Content(html,"text/html");
        }

        [HttpGet("skills/form")]
        public IActionResult DisplayForm()
        {
            

            string html = "<form method='post' action='form/completed'>" +
                "<label for= 'date'> Date:</label>"+
                 "<input type='date' id = 'date' name='date' />" +
                 "<br>"+
                 "<label for='c'>C#</label>" +
                "<select name='c' id= 'c'>" +
                "<option value = 'Learning Basics' > Learning Basics </option>" +
                "<option value = 'Making Apps' > Making Apps </option>" +
                "<option value = 'Master Coder' >Master Coder</option>" +
                "</select>" +
                "<br>" +
                "<label for='j'>JavaScript</label>" +
                "<select name='j' id= 'j'>"+
                "<option value = 'Learning Basics' > Learning Basics </option>" +
                "<option value = 'Making Apps' > Making Apps </option>" +
                "<option value = 'Master Coder' >Master Coder</option>" +
                "</select>" +
                "<br>" +
                "<label for='p'>Python</label>" +
                "<select name='p' id= 'p'>"+
                "<option value = 'Learning Basics' > Learning Basics </option>" +
                "<option value = 'Making Apps' > Making Apps </option>" +
                "<option value = 'Master Coder' >Master Coder</option>" +
                "</select>" +
                "<br>" +
                "<input type='submit' value='Submit' />" +
                "</form>";

            return Content(html, "text/html");
        }


        [HttpPost("skills/form/completed")]
        public IActionResult Form(string date,string c,string j,string p)
        {
            string html = "<h1>"+date+"</h1>"+
                          "<ol>" +
                          "<li>C#: "+c+"</li>" +
                          "<li>JavaScript: "+j+"</li>" +
                          "<li>Python: " +p+"</li>" +
                          "</ol>";

            return Content(html, "text/html");
        }


    }
}
