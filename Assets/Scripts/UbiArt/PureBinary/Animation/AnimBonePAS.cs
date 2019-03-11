using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimBonePAS::serialize
	public class AnimBonePAS {
		public ushort unk0;
		public short unk1;
		public short unk2;
		public short unk3;
		public short unk4;
		public short unk5;

		public AnimBonePAS(Reader reader) {
			unk0 = reader.ReadUInt16();
			unk1 = reader.ReadInt16();
			unk2 = reader.ReadInt16();
			unk3 = reader.ReadInt16();
			unk4 = reader.ReadInt16();
			unk5 = reader.ReadInt16();
		}
		/*
		Example (from yellow_afraid_to_red_afraid.anm.ckd):
		0000 E7A4 1D90 0AFD 3A66 2C61
		0000 7EBB 99C2 EAB6 3BBE 2C22
		0000 0000 0000 0000 62AD 62AD
		0002 0E21 F6FC F917 62AD 62AD
		0003 0E21 F6FC F917 62AD 62AD
		0005 0000 0000 0000 62AD 62AD
		0006 0000 0000 0000 62AD 62AD
		0008 0E21 F6FC F917 62AD 62AD
		0009 0E21 F6FC F917 62AD 62AD
		000B 0000 0000 0000 62AD 62AD
		000C 0000 0000 0000 62AD 62AD
		000E 0E21 F6FC F917 62AD 62AD
		000F 0E21 F6FC F917 62AD 62AD
		0011 0000 0000 0000 62AD 62AD
		0000 F634 E618 F27C 62AD 62AD
		0001 F97C ED9E 0EB4 57C1 70B4
		0003 FC4B F412 26E4 4E64 7CBA
		0008 FCC3 F525 2AEC 4CD5 7EBB
		0009 F9D9 EE75 11D6 568A 7243
		000B F614 E7FA E914 6B72 5AA0
		000E F62F E668 F0EB 6423 6156
		0011 F634 E618 F27C 62AD 62AD
		*/
	}
}
