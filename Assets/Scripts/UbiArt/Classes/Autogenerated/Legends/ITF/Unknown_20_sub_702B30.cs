using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_20_sub_702B30 : CSerializable {
		[Serialize("enterShape"           )] public Placeholder enterShape;
		[Serialize("enterPoint0"          )] public Vector2 enterPoint0;
		[Serialize("enterPoint1"          )] public Vector2 enterPoint1;
		[Serialize("playerSpeedMultiplier")] public float playerSpeedMultiplier;
		[Serialize("travelSpeed"          )] public float travelSpeed;
		[Serialize("scale"                )] public float scale;
		[Serialize("catchCooldown"        )] public float catchCooldown;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enterShape));
			SerializeField(s, nameof(enterPoint0));
			SerializeField(s, nameof(enterPoint1));
			SerializeField(s, nameof(playerSpeedMultiplier));
			SerializeField(s, nameof(travelSpeed));
			SerializeField(s, nameof(scale));
			SerializeField(s, nameof(catchCooldown));
		}
		public override uint? ClassCRC => 0x8616D48B;
	}
}

