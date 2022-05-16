using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }

        //

        public void OnGet(string? name, int? age)
        {
            if (name != null && age != null)
            {
                if (age > 21)
                {
                    Message = "����� ����������";
                    Age = age;
                    Name = name;
                }
                else Message = "��� ��� �� ����";
            } else
            {
                Message = "�� �� ����� ������� ������!";
            }
        }
    }
}
