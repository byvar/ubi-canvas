using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class SpecificDeviceConfig : CSerializable {
		public string configName;
		public bool ignoreMe;
		public CArray<string> models;
		public float scale;
		public uint deviceSpeed;
		public bool enableTextureCompression;
		public bool enableVHSFX;
		public bool enableResolutionLimitation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			configName = s.Serialize<string>(configName, name: "configName");
			ignoreMe = s.Serialize<bool>(ignoreMe, name: "ignoreMe");
			models = s.SerializeObject<CArray<string>>(models, name: "models");
			models = s.SerializeObject<CArray<string>>(models, name: "models");
			scale = s.Serialize<float>(scale, name: "scale");
			deviceSpeed = s.Serialize<uint>(deviceSpeed, name: "deviceSpeed");
			enableTextureCompression = s.Serialize<bool>(enableTextureCompression, name: "enableTextureCompression");
			enableVHSFX = s.Serialize<bool>(enableVHSFX, name: "enableVHSFX");
			enableResolutionLimitation = s.Serialize<bool>(enableResolutionLimitation, name: "enableResolutionLimitation");
		}
	}
}

