using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_OceanSpiderAIComponent_Template : RO2_SimpleAIComponent_Template {
		[Serialize("addHitInputName" )] public StringID addHitInputName;
		[Serialize("buboPath"        )] public Path buboPath;
		[Serialize("buboBoneName"    )] public StringID buboBoneName;
		[Serialize("deathAnimName"   )] public StringID deathAnimName;
		[Serialize("numBubbles"      )] public int numBubbles;
		[Serialize("bubblePrizeBox"  )] public AABB bubblePrizeBox;
		[Serialize("bubblePrizePaths")] public Placeholder bubblePrizePaths;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(addHitInputName));
				SerializeField(s, nameof(buboPath));
				SerializeField(s, nameof(buboBoneName));
				SerializeField(s, nameof(deathAnimName));
				SerializeField(s, nameof(numBubbles));
				SerializeField(s, nameof(bubblePrizePaths));
				SerializeField(s, nameof(bubblePrizeBox));
			} else {
				SerializeField(s, nameof(addHitInputName));
				SerializeField(s, nameof(buboPath));
				SerializeField(s, nameof(buboBoneName));
				SerializeField(s, nameof(deathAnimName));
				SerializeField(s, nameof(numBubbles));
				SerializeField(s, nameof(bubblePrizeBox));
			}
		}
		public override uint? ClassCRC => 0xB734FC74;
	}
}

