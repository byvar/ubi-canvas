using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.FriseOrigins {
	// See: ITF::FriseConfig::serialize
	// fcg.ckd file
	public class FriseConfigOrigins : CSerializable {
		[Serialize("version"    )] public uint version;
		[Serialize("unk0")] public CArray<int> unk0;
		[Serialize("unk1")] public CArray<int> unk1;
		[Serialize("textureConfig")] public CArray<FriseTextureConfig> textureConfig;


		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(version));
			SerializeField(s, nameof(unk0));
			SerializeField(s, nameof(unk1));
			SerializeField(s, nameof(textureConfig));
		}
	}
}
