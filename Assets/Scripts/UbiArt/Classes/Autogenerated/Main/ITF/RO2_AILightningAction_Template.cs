using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_AILightningAction_Template : AIAction_Template {
		[Serialize("startBoneName"  )] public StringID startBoneName;
		[Serialize("destBoneName"   )] public StringID destBoneName;
		[Serialize("defaultSize"    )] public float defaultSize;
		[Serialize("angleOffset"    )] public Angle angleOffset;
		[Serialize("hitLevel"       )] public uint hitLevel;
		[Serialize("hitType"        )] public uint hitType;
		[Serialize("useStartStim"   )] public bool useStartStim;
		[Serialize("useDestStim"    )] public bool useDestStim;
		[Serialize("startStimRadius")] public float startStimRadius;
		[Serialize("destStimRadius" )] public float destStimRadius;
		[Serialize("startStimOffset")] public Vector2 startStimOffset;
		[Serialize("destStimOffset" )] public Vector2 destStimOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(startBoneName));
			SerializeField(s, nameof(destBoneName));
			SerializeField(s, nameof(defaultSize));
			SerializeField(s, nameof(angleOffset));
			SerializeField(s, nameof(hitLevel));
			SerializeField(s, nameof(hitType));
			SerializeField(s, nameof(useStartStim));
			SerializeField(s, nameof(useDestStim));
			SerializeField(s, nameof(startStimRadius));
			SerializeField(s, nameof(destStimRadius));
			SerializeField(s, nameof(startStimOffset));
			SerializeField(s, nameof(destStimOffset));
		}
		public override uint? ClassCRC => 0x44AC731E;
	}
}

