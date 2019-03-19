using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_CrankComponent_Template : ActorComponent_Template {
		[Serialize("textPath"          )] public Path textPath;
		[Serialize("tvoffTextPath"     )] public Path tvoffTextPath;
		[Serialize("registerToCamera"  )] public bool registerToCamera;
		[Serialize("hideTvoffTutoAngle")] public float hideTvoffTutoAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(textPath));
				SerializeField(s, nameof(tvoffTextPath));
				SerializeField(s, nameof(registerToCamera));
				SerializeField(s, nameof(hideTvoffTutoAngle));
			} else {
				SerializeField(s, nameof(textPath));
				SerializeField(s, nameof(tvoffTextPath));
				SerializeField(s, nameof(registerToCamera));
			}
		}
		public override uint? ClassCRC => 0xC33A43A1;
	}
}

