using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class SpecificDeviceConfig : CSerializable {
		[Serialize("configName"                )] public string configName;
		[Serialize("ignoreMe"                  )] public bool ignoreMe;
		[Serialize("models"                    )] public CArray<string> models;
		[Serialize("scale"                     )] public float scale;
		[Serialize("deviceSpeed"               )] public uint deviceSpeed;
		[Serialize("enableTextureCompression"  )] public bool enableTextureCompression;
		[Serialize("enableVHSFX"               )] public bool enableVHSFX;
		[Serialize("enableResolutionLimitation")] public bool enableResolutionLimitation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(configName));
			SerializeField(s, nameof(ignoreMe));
			SerializeField(s, nameof(models));
			SerializeField(s, nameof(models));
			SerializeField(s, nameof(scale));
			SerializeField(s, nameof(deviceSpeed));
			SerializeField(s, nameof(enableTextureCompression));
			SerializeField(s, nameof(enableVHSFX));
			SerializeField(s, nameof(enableResolutionLimitation));
		}
	}
}

