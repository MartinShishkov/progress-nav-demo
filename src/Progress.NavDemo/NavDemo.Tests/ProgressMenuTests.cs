using Bunit;
using NavDemo.Web.Models;
using NavDemo.Web.Shared.Components.ProgressMenu;
using Xunit;

namespace NavDemo.Tests
{
    public class ProgressMenuTests : TestContext
    {
        [Fact]
        public void MenuRendersCorrectMarkup()
        {
            var cut = RenderComponent<ProgressMenu>(
                ("Items", new[]
                {
                    new ProgressMenuItem(1, "root 1", i => {}, new[]
                    {
                        new ProgressMenuItem(2, "1.1", i => {})
                    })
                })
            );

            cut.Find("nav").MarkupMatches(
                "<nav class=\"progress-menu\">" +
                "   <ul>" +
                "       <li class=\"root-item\">" +
                "            <a href=\"javascript:void(0);\">root 1 <i>▼</i></a>" +
                "            <ul class=\"sub-menu menu-bottom\">" +
                "               <li class=\"sub-item\">" +
                "                   <a href=\"javascript:void(0);\">1.1 <i></i></a>" +
                "               </li>" +
                "           </ul>"  + 
                "       </li>" +
                "   </ul>" +
                "</nav>"
            ); 
        }
    }
}