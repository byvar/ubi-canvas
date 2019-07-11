using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Localisation {
	// See: ITF::Localisation_Template::serialize
	// loc8 file
	public class Localisation_Template : CSerializable {
		[Serialize("strings")] public CMap<int, CMap<LocalisationId, LocText>> strings;
		[Serialize("audio")] public CMap<LocalisationId, LocAudio> audio;
		[Serialize("paths")] public CList<Path> paths;
		[Serialize("count")] public uint count;
		public uint[] unk;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(strings));
			SerializeField(s, nameof(audio));
			SerializeField(s, nameof(paths));
			// Special array with sometimes predefined size
			if (Settings.s.game == Settings.Game.RA) {
				// Adventures: length specified in file, but when writing, the script always writes 25.
				SerializeField(s, nameof(count));
			} else {
				// Legends: length not specified in file. When writing, the script always writes 19.
				count = 19;
			}
			if (unk == null) {
				unk = new uint[count];
			}
			for (int i = 0; i < count; i++) {
				if (s.ArrayEntryStart(name: nameof(unk), index: i)) {
					s.Serialize<uint>(ref unk[i], name: nameof(unk), index: i);
					s.ArrayEntryStop();
				}
			}
		}
	}
}
