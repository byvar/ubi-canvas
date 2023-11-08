
using System.IO;

namespace UbiArt.ITF {
	public partial class RO2_Brick_Template {
		public ContainerFile<Scene> sceneFile;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (IsFirstLoad) {
				Loader l = s.Context.Loader;
				l.Load(archive, path.filename, (extS) => {
					sceneFile = extS.SerializeObject<ContainerFile<Scene>>(sceneFile);
				});
			}
		}

		protected override void OnPreSerialize(CSerializerObject s) {
			base.OnPreSerialize(s);
			if (s is CSerializerObjectBinaryWriter sw && s.HasFlags(SerializeFlags.Flags10)) {
				if (sceneFile == null && path != null) {
					sceneFile = path.GetObject<ContainerFile<Scene>>();
					if (sceneFile?.obj != null) {
						sceneFile = new ContainerFile<Scene>() {
							obj = (Scene)sceneFile.obj.Clone("isc", context: s.Context)
						};
					}
				}


				if (sceneFile != null) {
					byte[] serializedData = null;
					using (MemoryStream stream = new MemoryStream()) {
						using (Writer writer = new Writer(stream, s.Settings.IsLittleEndian)) {
							CSerializerObjectBinaryWriter w = new CSerializerObjectBinaryWriter(s.Context, writer);
							Loader.ConfigureSerializeFlagsForExtension(ref w.flags, ref w.properties, path.GetExtension());
							object toWrite = sceneFile;
							w.Serialize(ref toWrite, sceneFile.GetType(), name: path.filename);
							serializedData = stream.ToArray();
						}
					}
					if (serializedData != null) {
						if(archive == null) archive = new ArchiveMemory();
						archive.AMData = serializedData;
					}
				}
			}
		}
	}
}
