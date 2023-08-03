namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class BMFMAPIHAJP
	{
		[ProtoMember(12)] public int Retcode;
		[ProtoMember(7)] public SceneInfo Scene;
	}
	
}
