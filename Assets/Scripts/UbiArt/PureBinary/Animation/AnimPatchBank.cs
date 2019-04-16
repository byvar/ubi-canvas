using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimPatchBank::serialize
	// pbk.ckd file
	public class AnimPatchBank : CSerializable {
		[Serialize("version"     )] public uint version;
		[Serialize("bankId"      )] public Link bankId;
		[Serialize("unk"         )] public float unk;
		[Serialize("templateKeys")] public KeyArray<int> templateKeys;
		[Serialize("templates"   )] public CList<AnimTemplate> templates;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(version));
			SerializeField(s, nameof(bankId));
			SerializeField(s, nameof(unk));
			SerializeField(s, nameof(templateKeys));
			SerializeField(s, nameof(templates));
		}

	}
}
