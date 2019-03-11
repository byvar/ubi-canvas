using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_RhythmicSequenceComponent_Template : ActorComponent_Template {
		[Serialize("input"              )] public StringID input;
		[Serialize("mainViewRendering"  )] public bool mainViewRendering;
		[Serialize("remoteViewRendering")] public bool remoteViewRendering;
		[Serialize("metronomeID"        )] public uint metronomeID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(input));
			SerializeField(s, nameof(mainViewRendering));
			SerializeField(s, nameof(remoteViewRendering));
			SerializeField(s, nameof(metronomeID));
		}
		public override uint? ClassCRC => 0x5D3FCD6E;
	}
}

