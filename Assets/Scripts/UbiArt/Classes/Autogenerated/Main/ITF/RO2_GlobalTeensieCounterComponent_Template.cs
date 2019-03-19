using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_GlobalTeensieCounterComponent_Template : ActorComponent_Template {
		[Serialize("locID"               )] public LocalisationId locID;
		[Serialize("standAnim"           )] public StringID standAnim;
		[Serialize("travelDuration"      )] public float travelDuration;
		[Serialize("fastTravelDuration"  )] public float fastTravelDuration;
		[Serialize("scale"               )] public float scale;
		[Serialize("apexScale"           )] public float apexScale;
		[Serialize("finaleScale"         )] public float finaleScale;
		[Serialize("intervalTime"        )] public float intervalTime;
		[Serialize("startFX"             )] public StringID startFX;
		[Serialize("endFX"               )] public StringID endFX;
		[Serialize("transitionDuration"  )] public float transitionDuration;
		[Serialize("nbRebound"           )] public uint nbRebound;
		[Serialize("startOffset"         )] public Vector2 startOffset;
		[Serialize("displayDuration"     )] public float displayDuration;
		[Serialize("pulseScaleMultiplier")] public float pulseScaleMultiplier;
		[Serialize("pulseIncreaseTime"   )] public float pulseIncreaseTime;
		[Serialize("pulseSustainTime"    )] public float pulseSustainTime;
		[Serialize("pulseDecreaseTime"   )] public float pulseDecreaseTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(locID));
			SerializeField(s, nameof(standAnim));
			SerializeField(s, nameof(travelDuration));
			SerializeField(s, nameof(fastTravelDuration));
			SerializeField(s, nameof(scale));
			SerializeField(s, nameof(apexScale));
			SerializeField(s, nameof(finaleScale));
			SerializeField(s, nameof(intervalTime));
			SerializeField(s, nameof(startFX));
			SerializeField(s, nameof(endFX));
			SerializeField(s, nameof(transitionDuration));
			SerializeField(s, nameof(nbRebound));
			SerializeField(s, nameof(startOffset));
			SerializeField(s, nameof(displayDuration));
			SerializeField(s, nameof(pulseScaleMultiplier));
			SerializeField(s, nameof(pulseIncreaseTime));
			SerializeField(s, nameof(pulseSustainTime));
			SerializeField(s, nameof(pulseDecreaseTime));
		}
		public override uint? ClassCRC => 0x741A5D27;
	}
}

