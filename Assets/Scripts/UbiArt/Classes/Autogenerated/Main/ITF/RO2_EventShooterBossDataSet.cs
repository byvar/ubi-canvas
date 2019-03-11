using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventShooterBossDataSet : Event {
		[Serialize("dataInt"  )] public int dataInt;
		[Serialize("dataFloat")] public float dataFloat;
		[Serialize("dataInt"  )] public bool dataInt;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(dataInt));
				SerializeField(s, nameof(dataFloat));
			} else {
				SerializeField(s, nameof(dataInt));
				SerializeField(s, nameof(dataFloat));
			}
		}
		public override uint? ClassCRC => 0x56C79B19;
	}
}

