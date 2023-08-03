namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneEntityMoveScRsp
	{
		[ProtoMember(2)] public List<EntityMotion> EntityMotionList;
		[ProtoMember(7)] public ClientDownloadData DownloadData;
		[ProtoMember(10)] public int Retcode;
	}
	
}
