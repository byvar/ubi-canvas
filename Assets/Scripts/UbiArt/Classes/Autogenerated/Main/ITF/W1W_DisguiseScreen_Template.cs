using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_DisguiseScreen_Template : W1W_InteractiveGenComponent_Template {
		[Serialize("Path__0"   )] public Path Path__0;
		[Serialize("Vector2__1")] public Vec2d Vector2__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Path__0));
			SerializeField(s, nameof(Vector2__1));
		}
		public override uint? ClassCRC => 0x670DD7ED;
	}
}

