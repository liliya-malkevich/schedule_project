using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;


namespace Service
{
    public class TeacherAreaAuthorization : IControllerModelConvention
    {
        private readonly string area;
        private readonly string policy;
        public TeacherAreaAuthorization(string area, string policy)
        {
            this.area = area;
            this.policy = policy;
        }

        //проверяем атрибуты для контроллера
        public void Apply(ControllerModel controller)
        {
            if (controller.Attributes.Any(a => a is AreaAttribute
                && (a as AreaAttribute).RouteValue.Equals(area, StringComparison.OrdinalIgnoreCase))
                || controller.RouteValues.Any(r => r.Key.Equals("area", StringComparison.OrdinalIgnoreCase)
                && r.Value.Equals(area, StringComparison.OrdinalIgnoreCase)))
            {
                //отправляем пользователя на авторизаию
                controller.Filters.Add(new AuthorizeFilter(policy));
            }

        }
    }
}