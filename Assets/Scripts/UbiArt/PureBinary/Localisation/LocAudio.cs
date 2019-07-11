using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Localisation {
	// See: ITF::LocAudio::serialize
	public class LocAudio : CSerializable {
		[Serialize("unk")] public uint unk;
		[Serialize("text")] public string text;
		[Serialize("unk0")] public byte unk0;
		[Serialize("unk1")] public byte unk1;
		[Serialize("unk2")] public byte unk2;
		[Serialize("unk3")] public byte unk3;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(unk));
			SerializeField(s, nameof(text));
			SerializeField(s, nameof(unk0));
			SerializeField(s, nameof(unk1));
			SerializeField(s, nameof(unk2));
			SerializeField(s, nameof(unk3));
		}
	}
}
