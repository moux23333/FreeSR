namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EnterSceneScRsp
	{
		[ProtoMember(1)] public SceneInfo Scene;
		[ProtoMember(3)] public int Retcode;
	}

}
