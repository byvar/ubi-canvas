using System.Linq;

namespace UbiArt.UV {
	public class UVAtlas : CSerializable {
		public static uint versionLegends = 0xC;
		public static uint versionAdventures = 0x12;
		public uint version;
		public CMap<int, UVdata> uvData;
		public CMap<int, UVparameters> uvParams;
		public CMap<int, Vec3d> pivots;
		public float scaleX = 1f;
		public float scaleY = 1f;

		protected override void SerializeImpl(CSerializerObject s) {
			version = s.Serialize<uint>(version, name: "version");
			uvData = s.SerializeObject<CMap<int, UVdata>>(uvData, name: "uvData");
			if (s.Settings.engineVersion > Settings.EngineVersion.RO) {
				uvParams = s.SerializeObject<CMap<int, UVparameters>>(uvParams, name: "uvParams");
				if (s.Settings.game == Settings.Game.RA || s.Settings.game == Settings.Game.RM) {
					pivots = s.SerializeObject<CMap<int, Vec3d>>(pivots, name: "pivots");
					scaleX = s.Serialize<float>(scaleX, name: "scaleX");
					scaleY = s.Serialize<float>(scaleY, name: "scaleY");
				}
			}
		}

		public void Reinit(Settings settings) {
			if (settings.game == Settings.Game.RL && version >= versionLegends) {
				version = versionLegends;
				if (scaleX != 1f || scaleY != 1f) {
					foreach (var uvdat in uvData) {
						foreach (var uv in uvdat.Value.uvs) {
							uv.x = uv.x / scaleX;
							uv.y = uv.y / scaleY;
						}
					}
					scaleX = 1f;
					scaleY = 1f;
				}
				/*if (uvParams != null) {
					foreach (var uvParam in uvParams) {
						var val = uvParam.Value;
						if (val.triangles != null && val.triangles.Count > 0) {
							if (val.parameters == null || val.parameters.Count == 0) {
								var maxVertCount = uvData[uvParam.Key].uvs.Count;
								val.parameters = new CArrayO<UVparameters.Parameters>(
									Enumerable.Repeat(new UVparameters.Parameters() {
										x = 1,
										y = 0,
									}, maxVertCount).ToArray());
							}
						}
					}
				}*/
			}
		}
		protected override void OnPreSerialize(CSerializerObject s) {
			base.OnPreSerialize(s);
			Reinit(s.Settings);
		}

	}
}
