using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Localisation {
	// See: ITF::LocText::serialize
	public class LocText : CSerializable {
		public string text;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			text = s.Serialize<string>(text, name: "text");
		}
	}
}
