namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneActorInfo
	{
		[ProtoMember(9)] public int MapLayer;
		[ProtoMember(5)] public int Uid;
		[ProtoMember(2)] public AvatarType AvatarType;
		[ProtoMember(12)] public int BaseAvatarId;
	}

}
