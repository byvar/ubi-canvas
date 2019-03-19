using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class AISimplePlayAnimBehavior_Template : TemplateAIBehavior {
		[Serialize("playAnim")] public Generic<AIPlayAnimAction_Template> playAnim;
		[Serialize("name"    )] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(name));
			} else {
				SerializeField(s, nameof(playAnim));
			}
		}
		public override uint? ClassCRC => 0xE1DF1C45;
	}
}

