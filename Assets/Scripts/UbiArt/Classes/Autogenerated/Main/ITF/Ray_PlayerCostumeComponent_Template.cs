using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_PlayerCostumeComponent_Template : ActorComponent_Template {
		[Serialize("newIconPath"  )] public Path newIconPath;
		[Serialize("newIconOffset")] public Vector3 newIconOffset;
		[Serialize("playerIDInfo" )] public StringID playerIDInfo;
		[Serialize("animLocked"   )] public StringID animLocked;
		[Serialize("animShown"    )] public StringID animShown;
		[Serialize("animAvailable")] public StringID animAvailable;
		[Serialize("animUsed"     )] public StringID animUsed;
		[Serialize("fx"           )] public Path fx;
		[Serialize("shape"        )] public Generic<PhysShape> shape;
		[Serialize("shapeOffset"  )] public Vector2 shapeOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(newIconPath));
			SerializeField(s, nameof(newIconOffset));
			SerializeField(s, nameof(playerIDInfo));
			SerializeField(s, nameof(animLocked));
			SerializeField(s, nameof(animShown));
			SerializeField(s, nameof(animAvailable));
			SerializeField(s, nameof(animUsed));
			SerializeField(s, nameof(fx));
			SerializeField(s, nameof(shape));
			SerializeField(s, nameof(shapeOffset));
		}
		public override uint? ClassCRC => 0x311111BB;
	}
}

