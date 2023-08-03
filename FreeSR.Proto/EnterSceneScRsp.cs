namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EnterSceneScRsp
	{
		[ProtoMember(8)] public SceneInfo Scene;
		[ProtoMember(4)] public int Retcode;
	}
	
}
