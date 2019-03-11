using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_353_sub_AE1CA0 : CSerializable {
		[Serialize("waitAnim"            )] public StringID waitAnim;
		[Serialize("staticAnim"          )] public StringID staticAnim;
		[Serialize("runAnim"             )] public StringID runAnim;
		[Serialize("fallAnim"            )] public StringID fallAnim;
		[Serialize("flyAnim"             )] public StringID flyAnim;
		[Serialize("transformAnim"       )] public StringID transformAnim;
		[Serialize("sailorAnim"          )] public StringID sailorAnim;
		[Serialize("wait2Anim"           )] public StringID wait2Anim;
		[Serialize("walkAnim"            )] public StringID walkAnim;
		[Serialize("jumpAnimStart"       )] public StringID jumpAnimStart;
		[Serialize("jumpAnimCycle"       )] public StringID jumpAnimCycle;
		[Serialize("jumpAnimStartToCycle")] public StringID jumpAnimStartToCycle;
		[Serialize("jumpAnimLanding"     )] public StringID jumpAnimLanding;
		[Serialize("detectionAnim"       )] public StringID detectionAnim;
		[Serialize("speed"               )] public float speed;
		[Serialize("walkSpeed"           )] public float walkSpeed;
		[Serialize("detectionAABB"       )] public Placeholder detectionAABB;
		[Serialize("escapeSpeed"         )] public float escapeSpeed;
		[Serialize("escapeSpeed2"        )] public float escapeSpeed2;
		[Serialize("escapeLength"        )] public float escapeLength;
		[Serialize("escapeHight"         )] public float escapeHight;
		[Serialize("playerDistFromLand"  )] public float playerDistFromLand;
		[Serialize("useRandomDetection"  )] public bool useRandomDetection;
		[Serialize("bezierControl"       )] public float bezierControl;
		[Serialize("afterEscapeDelay"    )] public float afterEscapeDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(waitAnim));
			SerializeField(s, nameof(staticAnim));
			SerializeField(s, nameof(runAnim));
			SerializeField(s, nameof(fallAnim));
			SerializeField(s, nameof(flyAnim));
			SerializeField(s, nameof(transformAnim));
			SerializeField(s, nameof(sailorAnim));
			SerializeField(s, nameof(wait2Anim));
			SerializeField(s, nameof(walkAnim));
			SerializeField(s, nameof(jumpAnimStart));
			SerializeField(s, nameof(jumpAnimCycle));
			SerializeField(s, nameof(jumpAnimStartToCycle));
			SerializeField(s, nameof(jumpAnimLanding));
			SerializeField(s, nameof(detectionAnim));
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(walkSpeed));
			SerializeField(s, nameof(detectionAABB));
			SerializeField(s, nameof(escapeSpeed));
			SerializeField(s, nameof(escapeSpeed2));
			SerializeField(s, nameof(escapeLength));
			SerializeField(s, nameof(escapeHight));
			SerializeField(s, nameof(playerDistFromLand));
			SerializeField(s, nameof(useRandomDetection));
			SerializeField(s, nameof(bezierControl));
			SerializeField(s, nameof(afterEscapeDelay));
		}
		public override uint? ClassCRC => 0x3E8AB050;
	}
}

