using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_GardenCreatureManager_Template : CSerializable {
		public Path gardenPath;
		public Path gemIconPath;
		public float gardenCamIPadDezoom;
		public float gardenCamIPhoneXZoom;
		public float gardenCamIPhoneX_Y_Value;
		public Placeholder families;
		public Placeholder gemValuesByRarity;
		public Placeholder gemValuesOnTouch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			gardenPath = s.SerializeObject<Path>(gardenPath, name: "gardenPath");
			gemIconPath = s.SerializeObject<Path>(gemIconPath, name: "gemIconPath");
			gardenCamIPadDezoom = s.Serialize<float>(gardenCamIPadDezoom, name: "gardenCamIPadDezoom");
			gardenCamIPhoneXZoom = s.Serialize<float>(gardenCamIPhoneXZoom, name: "gardenCamIPhoneXZoom");
			gardenCamIPhoneX_Y_Value = s.Serialize<float>(gardenCamIPhoneX_Y_Value, name: "gardenCamIPhoneX_Y_Value");
			families = s.SerializeObject<Placeholder>(families, name: "families");
			gemValuesByRarity = s.SerializeObject<Placeholder>(gemValuesByRarity, name: "gemValuesByRarity");
			gemValuesOnTouch = s.SerializeObject<Placeholder>(gemValuesOnTouch, name: "gemValuesOnTouch");
		}
		public override uint? ClassCRC => 0xD285DC1E;
	}
}

