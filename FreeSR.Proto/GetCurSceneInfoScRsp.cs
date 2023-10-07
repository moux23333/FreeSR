namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetCurSceneInfoScRsp
	{
		[ProtoMember(9)] public int Retcode;
		[ProtoMember(15)] public SceneInfo Scene;
	}

}
