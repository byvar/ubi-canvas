using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Localisation {
	// See: ITF::LocAudio::serialize
	public class LocAudio : CSerializable {
		[Serialize("text")] public string text;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(text));
		}
	}
}
