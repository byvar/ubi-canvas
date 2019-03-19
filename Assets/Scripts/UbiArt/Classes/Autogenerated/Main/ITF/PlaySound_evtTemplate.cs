using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class PlaySound_evtTemplate : SequenceEventWithActor_Template {
		[Serialize("Sound"   )] public Path Sound;
		[Serialize("Params"  )] public SoundParams Params;
		[Serialize("Volume"  )] public float Volume;
		[Serialize("Category")] public string Category;
		[Serialize("IsStrem" )] public int IsStrem;
		[Serialize("Params"  )] public Placeholder Params;
		[Serialize("Category")] public StringID Category;
		[Serialize("IsStream")] public int IsStream;
		[Serialize("Sound"   )] public string Sound;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(Sound));
				SerializeField(s, nameof(Params));
				SerializeField(s, nameof(Volume));
				SerializeField(s, nameof(Category));
				SerializeField(s, nameof(IsStrem));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(Sound));
				SerializeField(s, nameof(Params));
				SerializeField(s, nameof(Volume));
				SerializeField(s, nameof(Category));
				SerializeField(s, nameof(IsStream));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(Sound));
				SerializeField(s, nameof(Volume));
				SerializeField(s, nameof(Category));
				SerializeField(s, nameof(IsStream));
			} else {
				SerializeField(s, nameof(Sound));
			}
		}
		public override uint? ClassCRC => 0x8AD848D9;
	}
}

