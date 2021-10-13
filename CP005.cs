using System.Text.RegularExpressions;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System.Threading;
using System;
using TestProject.SDK;
using TestProject.SDK.Tests.Helpers;
using TestProject.SDK.Tests;
using TestProject.Common.Attributes;
using TestProject.Common.Enums;

namespace TestProject.Generated.Tests.MyFirstProject
{
	/// <summary>
	/// This class was automatically generated by TestProject
	/// Project: My first Project
	/// Test: CP005
	/// Generated by: Channyke Rodriguez (csrodriguez21@ucatolica.edu.co)
	/// Generated on: 10/13/2021 00:41:53
	/// </summary>
	public class CP005 : IWebTest
	{
		[ParameterAttribute(Description = "Auto generated application URL parameter", DefaultValue = "http://localhost/ActiveTime/", Direction = ParameterDirection.Input)]
		public string ApplicationURL;
		[ParameterAttribute(DefaultValue = "25", Direction = ParameterDirection.Input)]
		public string Idtarea;
		[ParameterAttribute(DefaultValue = "3", Direction = ParameterDirection.Input)]
		public string Prioridad;
		public ExecutionResult Execute(WebTestHelper helper)
		{
			var driver = helper.Driver;
			var report = helper.Reporter;
			bool boolResult;
			By by;
			ExecutionResult executionResult;
			io.testproject.addons.web.element.select.SelectOptionByValue selectAllOptionsByValueAttribute;
			
			// set timeout for driver actions (similar to step timeout)
			driver.Timeout = 15000;
			
			 // 1. Navigate to '{{ApplicationURL}}'
			// Navigates the specified URL (Auto-generated)
			// Add step sleep time (Before)
			Thread.Sleep(500);
			boolResult = driver.TestProject().NavigateToURL(ApplicationURL);
			report.Step(string.Format("Navigate to '{0}'", ApplicationURL), boolResult, TakeScreenshotConditionType.Failure);
			
			 // 2. Scroll window by ('0','62')
			// Add step sleep time (Before)
			Thread.Sleep(500);
			boolResult = driver.TestProject().ScrollWindow(0, 62);
			report.Step("Scroll window by ('0','62')", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 3. Click 'user'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#user");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'user'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 4. Type 'jdme1' in 'user'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#user");
			boolResult = driver.TestProject().TypeText(by, "jdme1");
			report.Step("Type 'jdme1' in 'user'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 5. Click 'password'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#password");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'password'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 6. Type 'lindo123!' in 'password'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#password");
			boolResult = driver.TestProject().TypeText(by, "lindo123!");
			report.Step("Type 'lindo123!' in 'password'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 7. Click 'Log in'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#ingresar");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'Log in'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 8. Scroll window by ('0','400')
			// Add step sleep time (Before)
			Thread.Sleep(500);
			boolResult = driver.TestProject().ScrollWindow(0, 400);
			report.Step("Scroll window by ('0','400')", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 9. Navigate to 'http://localhost/ActiveTime/assets/pages/Agregar-Tarea/index2.html'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			boolResult = driver.TestProject().NavigateToURL("http://localhost/ActiveTime/assets/pages/Agregar-Tarea/index2.html");
			report.Step("Navigate to 'http://localhost/ActiveTime/assets/pages/Agregar-Tarea/index2.html'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 10. Scroll window by ('0','399')
			// Add step sleep time (Before)
			Thread.Sleep(500);
			boolResult = driver.TestProject().ScrollWindow(0, 399);
			report.Step("Scroll window by ('0','399')", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 11. Click 'Change Priority'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#changePriority");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'Change Priority'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 12. Click 'task1'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#idTask");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'task1'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 13. Type '{{Idtarea}}' in 'task1'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#idTask");
			boolResult = driver.TestProject().TypeText(by, Idtarea);
			report.Step(string.Format("Type '{0}' in 'task1'", Idtarea), boolResult, TakeScreenshotConditionType.Failure);
			
			 // 14. Click 'priority'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#priority");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'priority'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 15. Select all '{{Prioridad}}' options in 'priority'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#priority");
			selectAllOptionsByValueAttribute = TestProject.Addons.Proxy.WebExtensions.CreateSelectOptionByValue(Prioridad);
			executionResult = helper.ExecuteProxy(selectAllOptionsByValueAttribute, by);
			report.Step(string.Format("Select all '{0}' options in 'priority'", Prioridad), executionResult == ExecutionResult.Passed, TakeScreenshotConditionType.Failure);
			
			 // 16. Click 'priority'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#priority");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'priority'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 17. Click 'Change'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#change-task");
			boolResult = driver.TestProject().Click(by);
			report.Step("Click 'Change'", boolResult, TakeScreenshotConditionType.Failure);
			
			return ExecutionResult.Passed;
		}
	}
}