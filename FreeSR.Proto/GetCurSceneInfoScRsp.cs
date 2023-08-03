namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetCurSceneInfoScRsp
	{
		[ProtoMember(9)] public int Retcode;
		[ProtoMember(8)] public SceneInfo Scene;
	}
	
}
