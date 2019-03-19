using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_KuyALumsComponent_Template : RO2_AIComponent_Template {
		[Serialize("animIdle"            )] public StringID animIdle;
		[Serialize("animPaint"           )] public StringID animPaint;
		[Serialize("animSquached"        )] public StringID animSquached;
		[Serialize("animImpact"          )] public StringID animImpact;
		[Serialize("animResist"          )] public StringID animResist;
		[Serialize("animExplode"         )] public StringID animExplode;
		[Serialize("fxStandPaint"        )] public StringID fxStandPaint;
		[Serialize("countLumsReward"     )] public uint countLumsReward;
		[Serialize("countLumsPaintReward")] public uint countLumsPaintReward;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animIdle));
			SerializeField(s, nameof(animPaint));
			SerializeField(s, nameof(animSquached));
			SerializeField(s, nameof(animImpact));
			SerializeField(s, nameof(animResist));
			SerializeField(s, nameof(animExplode));
			SerializeField(s, nameof(fxStandPaint));
			SerializeField(s, nameof(countLumsReward));
			SerializeField(s, nameof(countLumsPaintReward));
		}
		public override uint? ClassCRC => 0xA445AD17;
	}
}

