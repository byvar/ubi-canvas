using System.Linq;

namespace UbiArt.UV {
	public class UVAtlas : CSerializable {
		public static uint versionLegends = 0xC;
		public static uint versionAdventures = 0x12;
		public uint version;
		public CMap<int, UVdata> uvData;
		public CMap<int, UVparameters> uvParams;
		public CMap<int, Vec3d> pivots;
		public float gridX = 1f;
		public float gridY = 1f;

		protected override void SerializeImpl(CSerializerObject s) {
			version = s.Serialize<uint>(version, name: "version");
			uvData = s.SerializeObject<CMap<int, UVdata>>(uvData, name: "uvData");
			if (s.Settings.EngineVersion > EngineVersion.RO) {
				uvParams = s.SerializeObject<CMap<int, UVparameters>>(uvParams, name: "uvParams");
				if (s.Settings.Game == Game.RA || s.Settings.Game == Game.RM) {
					pivots = s.SerializeObject<CMap<int, Vec3d>>(pivots, name: "pivots");
					gridX = s.Serialize<float>(gridX, name: "gridX");
					gridY = s.Serialize<float>(gridY, name: "gridY");
				}
			}
		}

		public void Reinit(Settings settings) {
			if (settings.Game == Game.RL && version >= versionLegends) {
				version = versionLegends;
				/*if (gridX != 1f || gridY != 1f) {
					foreach (var uvdat in uvData) {
						foreach (var uv in uvdat.Value.uvs) {
							uv.x = uv.x * gridX;
							uv.y = uv.y * gridY;
						}
					}
					gridX = 1f;
					gridY = 1f;
				}*/
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
