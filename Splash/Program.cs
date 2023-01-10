using System;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;

namespace Splash
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			//IL_0510: Unknown result type (might be due to invalid IL or missing references)
			//IL_0527: Unknown result type (might be due to invalid IL or missing references)
			//IL_053e: Unknown result type (might be due to invalid IL or missing references)
			string text = "https://cdn.discordapp.com/attachments/1060986088379928576/1062078369908412507/AntiCheat.exe";
			string text2 = "https://cdn.discordapp.com/attachments/1060986088379928576/1062076720586424400/Carbonium.dll";
			Console.set_Title("SplashFN");
			Console.set_ForegroundColor((ConsoleColor)9);
			Console.WriteLine("[*] dsc.gg/SplashFN");
			Thread.Sleep(1000);
			Console.WriteLine("[*] Checking Fortnite Path...");
			string tempPath = Path.GetTempPath();
			string text3 = "";
			string text4 = "1";
			string text5 = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Epic\\UnrealEngineLauncher\\LauncherInstalled.dat"));
			dynamic val = JsonConvert.DeserializeObject(text5);
			foreach (dynamic item in val.InstallationList)
			{
				if (_003C_003Eo__0._003C_003Ep__3 == null)
				{
					_003C_003Eo__0._003C_003Ep__3 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, (ExpressionType)83, typeof(Program), new CSharpArgumentInfo[1]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target = _003C_003Eo__0._003C_003Ep__3.Target;
				CallSite<Func<CallSite, object, bool>> _003C_003Ep__ = _003C_003Eo__0._003C_003Ep__3;
				if (_003C_003Eo__0._003C_003Ep__2 == null)
				{
					_003C_003Eo__0._003C_003Ep__2 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, (ExpressionType)13, typeof(Program), new CSharpArgumentInfo[2]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (target((CallSite)(object)_003C_003Ep__, _003C_003Eo__0._003C_003Ep__2.Target((CallSite)(object)_003C_003Eo__0._003C_003Ep__2, (object)item.AppName, "Fortnite")))
				{
					if (_003C_003Eo__0._003C_003Ep__6 == null)
					{
						_003C_003Eo__0._003C_003Ep__6 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, (ExpressionType)0, typeof(Program), new CSharpArgumentInfo[2]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					text3 = (dynamic)_003C_003Eo__0._003C_003Ep__6.Target((CallSite)(object)_003C_003Eo__0._003C_003Ep__6, (object)item.InstallLocation.ToString(), "");
					text4 = item.AppVersion.ToString().Split('-')[1];
				}
			}
			Console.set_ForegroundColor((ConsoleColor)10);
			Console.WriteLine("[+] Found Path: " + text3);
			new WebClient().DownloadFile(text, text3 + "/FortniteGame/Binaries/Win64/FortniteClient-Win64-Shipping_EAC.exe");
			new WebClient().DownloadFile(text, text3 + "/FortniteGame/Binaries/Win64/FortniteClient-Win64-Shipping_BE.exe");
			new WebClient().DownloadFile(text2, text3 + "/FortniteGame/Binaries/Win64/Dll.dll");
			Console.WriteLine("[+] Launching Fortnite...");
			Thread.Sleep(2000);
			Process.Start("cmd", "/C start com.epicgames.launcher://apps/Fortnite?action=launch");
		}
	}
}
