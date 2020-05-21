using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using DotVVM.Framework.Hosting;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Builder;

namespace DotVVMControls.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {
		public string Title { get; set;}
		public PersonModel Person { get; set; } = new PersonModel { EnrollmentDate = DateTime.UtcNow.Date };
		

		public DefaultViewModel()
		{
			Title = "Person Form";
		}

		public void Process()
        {
			String script = "alert('" + "Welcome" + " " + Person.Username + " to Web App :) ')";
			Context.ResourceManager.AddStartupScript(script);
		}

	}
}
