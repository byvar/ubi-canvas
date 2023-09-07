using System;
using System.Reflection;
using System.Threading.Tasks;
using UbiArt;

namespace UbiCanvas.Tools
{
	public class LogFileTool : GameTool
	{
		public override string Name => "Deserialize & log file";
		public override string Description => "This tool deserializes the specified file so that it can be logged. The type specifies the C# data type to deserialize the file as. If the type is empty then the file is assumed to be generic.";

		public string FilePath { get; set; }
		public string Type { get; set; }

		public async Task DeserializeAsync()
		{
			using Context context = CreateContext();
			await context.Loader.LoadInitial();

			if (String.IsNullOrWhiteSpace(Type))
			{
				context.Loader.LoadGenericFile(new Path(FilePath), x => { });
			}
			else
			{
				MethodInfo laodMethodInfo = typeof(Loader).GetMethod(nameof(Loader.LoadFile), new[] { typeof(Path) } );
				laodMethodInfo = laodMethodInfo!.MakeGenericMethod(System.Type.GetType($"UbiArt.ITF.{Type}"));
				laodMethodInfo.Invoke(context.Loader, new object[] { new Path(FilePath) });
			}

			await context.Loader.LoadLoop();
		}
	}
}