using System;
using System.IO;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.ITF;
using UbiCanvas.Helpers;
using Path = UbiArt.Path;
using Stream = System.IO.Stream;

namespace UbiCanvas.Tools
{
	// TODO: Support all 3 saves slots, not just slot 0
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
			using Context context = CreateContext();
			Loader loader = context.Loader;

			await loader.LoadInitial();

			// Load the config first to get the encryption key
			loader.LoadGenericFile(new Path("enginedata/gameconfig/gameconfig.isg"), isg =>
			{
				loader.gameConfig = isg.obj as RO2_GameManagerConfig_Template;
			});
			loader.LoadUncooked<RLC_BinarySaveData>("DefaultSavegameName_0.sav", save =>
			{
				Util.ByteArrayToFile(System.IO.Path.Combine(context.BasePath, "DefaultSavegameName_0_decoded.sav"), save.CONTENT);
			});

			await context.Loader.LoadLoop();
		}

		private async Task EncodeAsync()
		{
			using Context context = CreateContext();
			Loader loader = context.Loader;

			await loader.LoadInitial();

			// Load the config first to get the encryption key
			loader.LoadGenericFile(new Path("enginedata/gameconfig/gameconfig.isg"), isg =>
			{
				loader.gameConfig = isg.obj as RO2_GameManagerConfig_Template;
			});
			loader.LoadUncooked<RLC_BinarySaveData>("DefaultSavegameName_0.sav", save =>
			{
				string inputPath = System.IO.Path.Combine(context.BasePath, "DefaultSavegameName_0_decoded.sav");
				string outputPath = System.IO.Path.Combine(context.BasePath, "DefaultSavegameName_0_encoded.sav");

				using Stream inputStream = File.OpenRead(inputPath);

				// Compress
				using Stream compressedStream = new MemoryStream();
				compressedStream.Position = 12; // Save space for header
				new ZlibEncoder(0, 0).EncodeStream(inputStream, compressedStream);
				compressedStream.Position = 0;
				using Writer compressedStreamWriter = new(compressedStream, isLittleEndian: false);
				compressedStreamWriter.Write(2433158838U); // crc
				compressedStreamWriter.Write((uint)(compressedStream.Length - 8)); // size
				compressedStreamWriter.IsLittleEndian = true;
				compressedStreamWriter.Write((uint)inputStream.Length); // decompressed size
				compressedStreamWriter.IsLittleEndian = false;

				// Encrypt
				using Stream base64Stream = new MemoryStream();
				compressedStream.Position = 0;
				new Base64Encoder(compressedStream.Length).EncodeStream(compressedStream, base64Stream);

				using Stream teaStream = new MemoryStream();
				base64Stream.Position = 0;
				new TeaEncoder(base64Stream.Length, save.GetTeaKey(context)).EncodeStream(base64Stream, teaStream);

				// Save
				using Stream outputStream = File.Create(outputPath);
				using Writer outputStreamWriter = new(outputStream, isLittleEndian: false);
				outputStreamWriter.Write(save.header);
				outputStreamWriter.Write(3061729066U); // crc
				outputStreamWriter.Write((uint)teaStream.Length); // size
				teaStream.Position = 0;
				teaStream.CopyTo(outputStream);
			});

			await context.Loader.LoadLoop();
		}

		// Temporary class until we have a tag writer
		public class RLC_BinarySaveData : ICSerializable
		{
			public byte[] header = null;
			public byte[] CONTENT;

			public uint[] GetTeaKey(Context c)
			{
				var key = c.Loader.gameConfig.key;
				return new uint[] { key.Key1, key.Key2, key.Key3, key.Key4 };
			}

			public void Serialize(CSerializerObject s, string name)
			{
				if (s?.Context?.Loader?.gameConfig == null)
					throw new Exception("GameConfig needs to be loaded to load save data!");

				header = s.SerializeBytes(header, 0x120);
				s.DoEncrypted(GetTeaKey(s.Context), () => 
				{
					s.DoCompressed(() =>
					{
						CONTENT = s.SerializeBytes(CONTENT, s.Length);
					}, name: "CONTENT");
				}, name: "CONTENT");
			}
		}
	}
}