using System;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.ITF;
using Path = UbiArt.Path;

namespace UbiCanvas.Tools
{
	public class AdventuresSaveTool : MultiActionGameTool
	{
		public AdventuresSaveTool()
		{
			Actions.AddRange(new[]
			{
				new InvokableAction("Log", LogAsync),
				new InvokableAction("Decode", DecodeAsync),
				new InvokableAction("Encode", EncodeAsync),
			});
			Requirements.Add(new ModeGameToolRequirement(Settings.Mode.RaymanAdventuresAndroid));
        }

        public override string Name => "Adventures Save Decoder";
		public override string Description => "This tool reads, decodes and encodes Rayman Adventures saves";

		private async Task LogAsync()
		{
			using Context context = CreateContext();
			Loader loader = context.Loader;
			
			await loader.LoadInitial();

			// Load the config first to get the encryption key
			loader.LoadGenericFile(new Path("enginedata/gameconfig/gameconfig.isg"), isg =>
			{
				loader.gameConfig = isg.obj as RO2_GameManagerConfig_Template;
			});
			loader.LoadSaveFileAdventures("DefaultSavegameName_0.sav", save => { });

			await context.Loader.LoadLoop();
		}

		private async Task DecodeAsync()
		{
			throw new NotImplementedException();
		}

		private async Task EncodeAsync()
		{
			throw new NotImplementedException();
		}
	}
}