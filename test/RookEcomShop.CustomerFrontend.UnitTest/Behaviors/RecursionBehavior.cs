using System;
using System.Collections.Generic;
using AutoFixture;
using AutoFixture.Kernel;
namespace RookEcomShop.CustomerFrontend.UnitTest.Behaviors;
public class RecursionDepthBehavior : ISpecimenBuilderTransformation
{
    private readonly int _maxDepth;

    public RecursionDepthBehavior(int maxDepth)
    {
        _maxDepth = maxDepth;
    }

    public ISpecimenBuilderNode Transform(ISpecimenBuilder builder)
    {
        return new RecursionGuard(builder, new RecursionDepthHandler(_maxDepth));
    }

    private class RecursionDepthHandler : IRecursionHandler
    {
        private readonly int _maxDepth;
        private readonly Dictionary<object, int> _depths = new();

        public RecursionDepthHandler(int maxDepth)
        {
            _maxDepth = maxDepth;
        }

        public object HandleRecursiveRequest(object request, IEnumerable<object> recordedRequests)
        {
            if (!_depths.TryGetValue(request, out var depth))
            {
                depth = 0;
            }
            _depths[request] = depth + 1;

            if (_depths[request] > _maxDepth)
            {
                return new OmitSpecimen();
            }

            return new NoSpecimen();
        }
    }
}
