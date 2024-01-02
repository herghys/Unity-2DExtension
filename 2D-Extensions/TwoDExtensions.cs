using System;
using UnityEngine;

namespace Herhys.Extensions
{
	public static class TwoDExtensions
	{
		#region Sprite Creator
		/// <summary>
		/// Load Sprite from Texture 2D
		/// </summary>
		/// <param name="_texture"></param>
		/// <returns></returns>
		public static Sprite SpriteFromTexture2D(Texture2D _texture)
		{
			var texture = GetTexture2DCopy(_texture);
			return Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);
		}

		/// <summary>
		/// Load Sprite from Texture 2D
		/// </summary>
		/// <param name="_texture"></param>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <returns></returns>
		public static Sprite SpriteFromTexture2D(Texture2D _texture, int width, int height)
		{
			var texture = GetTexture2DCopy(_texture);
			return Sprite.Create(texture, new Rect(0.0f, 0.0f, width, height), new Vector2(0.5f, 0.5f), 100.0f);
		}

		/// <summary>
		/// Load Sprite from Texture 2D
		/// </summary>
		/// <param name="_texture"></param>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <param name="pivot"></param>
		/// <returns></returns>
		public static Sprite SpriteFromTexture2D(Texture2D _texture, int width, int height, Vector2 pivot)
		{
			var texture = GetTexture2DCopy(_texture);
			return Sprite.Create(texture, new Rect(0.0f, 0.0f, width, height), pivot, 100.0f);
		}

		/// <summary>
		/// Load Sprite from Texture 2D
		/// </summary>
		/// <param name="_texture"></param>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <param name="pivot"></param>
		/// <param name="ppu"></param>
		/// <returns></returns>
		public static Sprite SpriteFromTexture2D(Texture2D _texture, int width, int height, Vector2 pivot, float ppu)
		{
			var texture = GetTexture2DCopy(_texture);
			return Sprite.Create(texture, new Rect(0.0f, 0.0f, width, height), pivot, ppu);
		}
		#endregion

		#region Bytes
		/// <summary>
		/// Byte To String
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static string ConvertTextureToBase64(byte[] source) => Convert.ToBase64String(source);

		/// <summary>
		/// Byte To String
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static string ByteToBase64(this byte[] source) => Convert.ToBase64String(source);
		#endregion

		#region Loader
		#region Byte Array
		/// <summary>
		/// Load Texture 2D From byte[]
		/// </summary>
		/// <param name="byteSource"></param>
		/// <returns></returns>
		public static Texture2D LoadTexture2DFromBytes(byte[] byteSource)
		{
			Texture2D tex = new Texture2D(256, 256);
			tex.LoadImage(byteSource);
			return tex;
		}

		/// <summary>
		/// Load Texture 2D From byte[]
		/// </summary>
		/// <param name="byteSource"></param>
		/// <returns></returns>
		public static Texture2D ByteToTexture2D(this byte[] byteSource)
		{
			Texture2D tex = new Texture2D(256, 256);
			tex.LoadImage(byteSource);
			return tex;
		}

		/// <summary>
		/// Load Sprite From byte[]
		/// </summary>
		/// <param name="byteSource"></param>
		/// <returns></returns>
		public static Sprite LoadSpriteUsingBytes(byte[] byteSource)
		{
			Texture2D tex = new Texture2D(256, 256);
			tex.LoadImage(byteSource);
			return SpriteFromTexture2D(tex);
		}

		/// <summary>
		/// Load Sprite From byte[]
		/// </summary>
		/// <param name="byteSource"></param>
		/// <returns></returns>
		public static Sprite ByteToSprite(this byte[] byteSource)
		{
			Texture2D tex = new Texture2D(256, 256);
			tex.LoadImage(byteSource);
			return SpriteFromTexture2D(tex);
		}
		#endregion

		#region String Base64
		/// <summary>
		/// Load Texture 2D From Base64 byte[]
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static Texture2D LoadTexture2DFromBase64(string source)
		{
			Texture2D tex = new Texture2D(256, 256);
			tex.LoadImage(Convert.FromBase64String(source));
			return tex;
		}

		/// <summary>
		/// Load Texture 2D From Base64 byte[]
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static Texture2D Base64ToTexture2D(this string source)
		{
			Texture2D tex = new Texture2D(256, 256);
			tex.LoadImage(Convert.FromBase64String(source));
			return tex;
		}

		/// <summary>
		/// Load Sprite From Base64 byte[]
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static Sprite LoadSpriteFromBase64(string source)
		{
			Texture2D tex = new Texture2D(256, 256);
			tex.LoadImage(Convert.FromBase64String(source));
			return SpriteFromTexture2D(tex);
		}

		/// <summary>
		/// Load Sprite From Base64 byte[]
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static Sprite Base64ToSprite(this string source)
		{
			Texture2D tex = new Texture2D(256, 256);
			tex.LoadImage(Convert.FromBase64String(source));
			return SpriteFromTexture2D(tex);
		}
		#endregion
		#endregion

		#region Duplication
		/// <summary>
		/// Duplicate Texture 2D
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static Texture2D DuplicateTexture2D(this Texture2D source)
		{
			byte[] pixels = source.GetRawTextureData();
			Texture2D readable = new Texture2D(source.width, source.height, source.format, false);
			readable.LoadRawTextureData(pixels);
			readable.Apply();
			return readable;
		}

		/// <summary>
		/// Duplicate Texture 2D
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static Texture2D GetTexture2DDuplicate( Texture2D source)
		{
			byte[] pixels = source.GetRawTextureData();
			Texture2D readable = new Texture2D(source.width, source.height, source.format, false);
			readable.LoadRawTextureData(pixels);
			readable.Apply();
			return readable;
		}
		#endregion

		#region Copier
		/// <summary>
		/// Copy Texture 2D
		/// </summary>
		/// <param name="texture2d"></param>
		/// <returns></returns>
		public static Texture2D GetTexture2DCopy(Texture2D texture2d)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(
						 texture2d.width,
						 texture2d.height,
						 0,
						 RenderTextureFormat.Default,
						 RenderTextureReadWrite.sRGB);

			Graphics.Blit(texture2d, renderTexture);
			RenderTexture previous = RenderTexture.active;
			RenderTexture.active = renderTexture;
			Texture2D readableTextur2D = new Texture2D(texture2d.width, texture2d.height);
			readableTextur2D.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
			readableTextur2D.Apply();
			RenderTexture.active = previous;
			RenderTexture.ReleaseTemporary(renderTexture);
			return readableTextur2D;
		}

		/// <summary>
		/// Copy Texture 2D
		/// </summary>
		/// <param name="texture2d"></param>
		/// <returns></returns>
		public static Texture2D CopyTexture2D(this Texture2D texture2d)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(
						 texture2d.width,
						 texture2d.height,
						 0,
						 RenderTextureFormat.Default,
						 RenderTextureReadWrite.sRGB);

			Graphics.Blit(texture2d, renderTexture);
			RenderTexture previous = RenderTexture.active;
			RenderTexture.active = renderTexture;
			Texture2D readableTextur2D = new Texture2D(texture2d.width, texture2d.height);
			readableTextur2D.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
			readableTextur2D.Apply();
			RenderTexture.active = previous;
			RenderTexture.ReleaseTemporary(renderTexture);
			return readableTextur2D;
		}

		/// <summary>
		/// Copy Texture
		/// </summary>
		/// <param name="texture2d"></param>
		/// <returns></returns>
		public static Texture GetTextureCopy(Texture texture2d)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(
						 texture2d.width,
						 texture2d.height,
						 0,
						 RenderTextureFormat.Default,
						 RenderTextureReadWrite.sRGB);

			Graphics.Blit(texture2d, renderTexture);
			RenderTexture previous = RenderTexture.active;
			RenderTexture.active = renderTexture;
			Texture2D readableTextur2D = new Texture2D(texture2d.width, texture2d.height);
			readableTextur2D.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
			readableTextur2D.Apply();
			RenderTexture.active = previous;
			RenderTexture.ReleaseTemporary(renderTexture);
			return readableTextur2D;
		}

		/// <summary>
		/// Copy Texture
		/// </summary>
		/// <param name="texture2d"></param>
		/// <returns></returns>
		public static Texture CopyTexture(this Texture texture2d)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(
						 texture2d.width,
						 texture2d.height,
						 0,
						 RenderTextureFormat.Default,
						 RenderTextureReadWrite.sRGB);

			Graphics.Blit(texture2d, renderTexture);
			RenderTexture previous = RenderTexture.active;
			RenderTexture.active = renderTexture;
			Texture2D readableTextur2D = new Texture2D(texture2d.width, texture2d.height);
			readableTextur2D.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
			readableTextur2D.Apply();
			RenderTexture.active = previous;
			RenderTexture.ReleaseTemporary(renderTexture);
			return readableTextur2D;
		}
		#endregion
	}
}
