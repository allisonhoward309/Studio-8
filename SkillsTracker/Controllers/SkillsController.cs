using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        [HttpGet]
        [Route("/skills/")]
        public IActionResult Skills()
        {
            string head = "<h1>" + "Skills Tracker" + "</h1>";
            string title = "<h2>" + "Learning Languages" + "</h2>";
            string languages = "<p><ol><li>" + "JavaScript" + "</li>"
                    + "<li>" + "C#" + "</li>" +
                    "<li>" + "Python" + "</li></ol></p>";
            string html = head + title + languages;
            return Content(html, "text/html");
        }
        [HttpGet]
        [Route("/skills/form")]
        public IActionResult Form()
        {
            string html = "<Form method = 'post' action='/skills/form'>" +
                "<h1>Date: </h1> <input type = 'date' id ='date' name = 'practiceDate'>" +
                "<h1>JavaScript: </h1><select name = 'javaScript'>"
                    + "<option value = ''> *Select One* </option>"
                    + "<option value = 'beginner'> Beginner </option>"
                    + "<option value = 'intermediate'> Intermediate </option>"
                    + "<option value = 'expert'> Expert </option>"
                + "</select> " +
                "<h1>C#: </h1><select name = 'c' id = 'c'>"
                    + "<option value = ''> *Select One* </option>"
                    + "<option value = 'beginner'> Beginner </option>"
                    + "<option value = 'intermediate'> Intermediate </option>"
                    + "<option value = 'expert'> Expert </option>"
                + "</select> " +
                "<h1>Python: </h1><select name = 'python' id = 'python'>"
                    + "<option value = ''> *Select One* </option>"
                    + "<option value = 'beginner' > Beginner </option>"
                    + "<option value = 'intermediate'> Intermediate </option>"
                    + "<option value = 'expert'> Expert </option>"
                + "</select> " +
                "<input type='submit' value='Submit' />";

            return Content(html, "text/html");
        }

        [HttpPost]
        [Route("/skills/form")]
        public IActionResult UpdateForm(string practiceDate,  string javaScript, string c, string python)
        {
            string head = $"<h1>" + practiceDate + "</h1>";
            string languages = "<p><ol><li>" + $"JavaScript: {javaScript}" + "</li>"
                    + "<li>" + $"C#: {c}" + "</li>" +
                    "<li>" + $"Python: {python}" + "</li></ol></p>";
            string html = head + languages;
            return Content(html, "text/html");

        }
    }
}
