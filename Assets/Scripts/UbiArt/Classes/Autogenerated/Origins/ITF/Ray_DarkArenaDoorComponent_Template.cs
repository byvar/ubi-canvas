using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_DarkArenaDoorComponent_Template : Ray_DarktoonTrapHoleComponent_Template {
		[Serialize("hitAnim" )] public StringID hitAnim;
		[Serialize("idleAnim")] public StringID idleAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(hitAnim));
			SerializeField(s, nameof(idleAnim));
		}
		public override uint? ClassCRC => 0x1B483F47;
	}
}

