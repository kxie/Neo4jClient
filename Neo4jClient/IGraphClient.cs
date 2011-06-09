﻿namespace Neo4jClient
{
    public interface IGraphClient
    {
        void Connect();
        NodeReference<TNode> Create<TNode>(TNode node, params IRelationshipAllowingParticipantNode<TNode>[] relationships) where TNode : class;
        TNode Get<TNode>(NodeReference reference);
        TNode Get<TNode>(NodeReference<TNode> reference);
    }
}