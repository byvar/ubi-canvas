using System.Reflection;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class GFXMaterialTexturePathSet {
		public TextureCooked tex_diffuse;
		public TextureCooked tex_back_light;
		public TextureCooked tex_normal;
		public TextureCooked tex_separateAlpha;
		public TextureCooked tex_diffuse_2;
		public TextureCooked tex_back_light_2;
		public TextureCooked tex_anim_impostor;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (IsFirstLoad) {
				LoadTexture(s.Context, nameof(tex_diffuse), diffuse);
				LoadTexture(s.Context, nameof(tex_back_light), back_light);
				LoadTexture(s.Context, nameof(tex_separateAlpha), separateAlpha);
				/*LoadTexture(nameof(tex_normal), normal);
				LoadTexture(nameof(tex_diffuse_2), diffuse_2);
				LoadTexture(nameof(tex_back_light_2), back_light_2);
				LoadTexture(nameof(tex_anim_impostor), anim_impostor);*/
			}
		}

		protected void LoadTexture(Context context, string fieldName, Path path) {
			Context l = context;
			l.Load(path, (extS) => {
				FieldInfo f = GetType().GetField(fieldName);
				if (l.tex.ContainsKey(path.stringID)) {
					f.SetValue(this, l.tex[path.stringID]);
				} else {
					TextureCooked tex = (TextureCooked)f.GetValue(this);
					tex = extS.SerializeObject<TextureCooked>(tex);
					f.SetValue(this, tex);
					tex.atlas = l.uvAtlasManager.GetAtlasIfExists(path);
					l.tex[path.stringID] = tex;
					if (extS.Position != extS.Length) {
						l.print("Read:" + extS.Position + " - Length:" + extS.Length + " - " + (extS.Position == extS.Length ? "good!" : "bad!"));
					}
				}
			});
		}
	}
}
