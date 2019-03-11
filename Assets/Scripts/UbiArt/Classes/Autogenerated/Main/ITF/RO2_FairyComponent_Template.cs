using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_FairyComponent_Template : ActorComponent_Template {
		[Serialize("flyDist"                   )] public float flyDist;
		[Serialize("flySpeed"                  )] public float flySpeed;
		[Serialize("flyAccelerationMultiplier" )] public float flyAccelerationMultiplier;
		[Serialize("rushDist"                  )] public float rushDist;
		[Serialize("rushSpeed"                 )] public float rushSpeed;
		[Serialize("rushAccelerationMultiplier")] public float rushAccelerationMultiplier;
		[Serialize("keepRushTime"              )] public float keepRushTime;
		[Serialize("displayDialogStill"        )] public bool displayDialogStill;
		[Serialize("lumPath"                   )] public Path lumPath;
		[Serialize("drcSlowEnabled"            )] public bool drcSlowEnabled;
		[Serialize("drcSlowFactor"             )] public float drcSlowFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(flyDist));
			SerializeField(s, nameof(flySpeed));
			SerializeField(s, nameof(flyAccelerationMultiplier));
			SerializeField(s, nameof(rushDist));
			SerializeField(s, nameof(rushSpeed));
			SerializeField(s, nameof(rushAccelerationMultiplier));
			SerializeField(s, nameof(keepRushTime));
			SerializeField(s, nameof(displayDialogStill));
			SerializeField(s, nameof(lumPath));
			SerializeField(s, nameof(drcSlowEnabled));
			SerializeField(s, nameof(drcSlowFactor));
		}
		public override uint? ClassCRC => 0x87EF869B;
	}
}

