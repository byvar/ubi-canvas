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
		public CMap<int, CMap<LocalisationId, LocText>> strings;
		public CMap<LocalisationId, LocAudio> audio;
		public CListO<Path> paths;
		public uint count;
		public uint[] unk;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			strings = s.SerializeObject<CMap<int, CMap<LocalisationId, LocText>>>(strings, name: "strings");
			audio = s.SerializeObject<CMap<LocalisationId, LocAudio>>(audio, name: "audio");
			paths = s.SerializeObject<CListO<Path>>(paths, name: "paths");
			// Special array with sometimes predefined size
			if (Settings.s.game == Settings.Game.RA || Settings.s.game == Settings.Game.RM) {
				// Adventures: length specified in file, but when writing, the script always writes 25.
				count = s.Serialize<uint>(count, name: "count");
			} else {
				// Legends: length not specified in file. When writing, the script always writes 19.
				count = 19;
			}
			if (unk == null) {
				unk = new uint[count];
			}
			for (int i = 0; i < count; i++) {
				if (s.ArrayEntryStart(name: nameof(unk), index: i)) {
					unk[i] = s.Serialize<uint>(unk[i], name: nameof(unk), index: i);
					s.ArrayEntryStop();
				}
			}
		}
	}
}
