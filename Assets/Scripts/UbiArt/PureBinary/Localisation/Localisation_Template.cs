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
		[Serialize("unk")] public CList<int> unk;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(strings));
			SerializeField(s, nameof(audio));
			SerializeField(s, nameof(paths));
			SerializeField(s, nameof(unk));
		}
	}
}
