using UnityEngine;

namespace UbiArt.ITF {
	public partial class BaseCurveParams : CSerializable {
		[Serialize("xofs"  )] public float xofs;
		[Serialize("yofs"  )] public float yofs;
		[Serialize("xScale")] public float xScale;
		[Serialize("yScale")] public float yScale;
		[Serialize("xMin"  )] public float xMin;
		[Serialize("xMax"  )] public float xMax;
		[Serialize("yMin"  )] public float yMin;
		[Serialize("yMax"  )] public float yMax;
		[Serialize("loop"  )] public bool loop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
			} else {
				SerializeField(s, nameof(xofs));
				SerializeField(s, nameof(yofs));
				SerializeField(s, nameof(xScale));
				SerializeField(s, nameof(yScale));
				SerializeField(s, nameof(xMin));
				SerializeField(s, nameof(xMax));
				SerializeField(s, nameof(yMin));
				SerializeField(s, nameof(yMax));
				SerializeField(s, nameof(loop));
			}
		}
		public override uint? ClassCRC => 0x9E41C323;
	}
}

