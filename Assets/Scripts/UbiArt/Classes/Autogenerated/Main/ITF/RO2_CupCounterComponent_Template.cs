using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_CupCounterComponent_Template : ActorComponent_Template {
		[Serialize("locID"          )] public LocalisationId locID;
		[Serialize("bronzeCup"      )] public Path bronzeCup;
		[Serialize("silverCup"      )] public Path silverCup;
		[Serialize("goldCup"        )] public Path goldCup;
		[Serialize("bronzetextColor")] public string bronzetextColor;
		[Serialize("silvertextColor")] public string silvertextColor;
		[Serialize("goldTextColor"  )] public string goldTextColor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(locID));
			SerializeField(s, nameof(bronzeCup));
			SerializeField(s, nameof(silverCup));
			SerializeField(s, nameof(goldCup));
			SerializeField(s, nameof(bronzetextColor));
			SerializeField(s, nameof(silvertextColor));
			SerializeField(s, nameof(goldTextColor));
		}
		public override uint? ClassCRC => 0xDAAB883A;
	}
}

