using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_MamaEyesComponent_Template : ActorComponent_Template {
		[Serialize("gravity"  )] public float gravity;
		[Serialize("rotation" )] public float rotation;
		[Serialize("scaleMin" )] public float scaleMin;
		[Serialize("scaleMax" )] public float scaleMax;
		[Serialize("initSpeed")] public Vector3 initSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(initSpeed));
				SerializeField(s, nameof(gravity));
				SerializeField(s, nameof(rotation));
				SerializeField(s, nameof(scaleMin));
				SerializeField(s, nameof(scaleMax));
			} else {
				SerializeField(s, nameof(gravity));
				SerializeField(s, nameof(rotation));
				SerializeField(s, nameof(scaleMin));
				SerializeField(s, nameof(scaleMax));
			}
		}
		public override uint? ClassCRC => 0x06481B58;
	}
}

