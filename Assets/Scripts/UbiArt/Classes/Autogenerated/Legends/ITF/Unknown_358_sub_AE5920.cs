using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_358_sub_AE5920 : CSerializable {
		[Serialize("launchBone"       )] public StringID launchBone;
		[Serialize("launchZOffset"    )] public float launchZOffset;
		[Serialize("launchInRootScene")] public bool launchInRootScene;
		[Serialize("standAnim"        )] public StringID standAnim;
		[Serialize("fireAnim"         )] public StringID fireAnim;
		[Serialize("runAnim"          )] public StringID runAnim;
		[Serialize("MonkeyType"       )] public char MonkeyType;
		[Serialize("initialSpeed"     )] public Vector2 initialSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(launchBone));
			SerializeField(s, nameof(launchZOffset));
			SerializeField(s, nameof(launchInRootScene));
			SerializeField(s, nameof(standAnim));
			SerializeField(s, nameof(fireAnim));
			SerializeField(s, nameof(runAnim));
			SerializeField(s, nameof(MonkeyType));
			SerializeField(s, nameof(initialSpeed));
		}
		public override uint? ClassCRC => 0xD07942D4;
	}
}

