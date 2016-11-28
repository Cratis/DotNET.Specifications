﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Einar Ingebrigtsen. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Cratis.Core.Specifications
{
    /// <summary>
    /// Base class for expressing a complex rule in code.  Utilising the Specification pattern. 
    /// </summary>
    /// <typeparam name="T">Type that the rule applies to</typeparam>
    /// <remarks>Based on http://bloggingabout.net/blogs/dries/archive/2011/09/29/specification-pattern-continued.aspx 
    /// </remarks>
    public abstract class Specification<T>
    {
        /// <summary>
        /// Compiled predicate for use against an instance
        /// </summary>
        protected Func<T, bool> _evalCompiled;
        /// <summary>
        /// Predicate as an expression for use against IQueryable collection
        /// </summary>
        protected Expression<Func<T, bool>> _evalExpression;

        /// <summary>
        /// Predicate rule to be evaluated
        /// </summary>
        protected internal Expression<Func<T, bool>> Predicate
        {
            get
            {
                return _evalExpression;
            }
            set
            {
                _evalExpression = value;
                _evalCompiled = _evalExpression.Compile();
            }
        }

        /// <summary>
        /// Evalutes the rule against a single instance of type T.
        /// </summary>
        /// <param name="instance">The instance to evaluation the rule against.</param>
        /// <returns>true if the rule is satisfied, false if the rule is broken</returns>
        public bool IsSatisfiedBy(T instance)
        {
            return _evalCompiled(instance);
        }

        /// <summary>
        /// Evaluates the rule against each instance of an IEnumerable[T]
        /// </summary>
        /// <param name="candidates">The IEnumerable[T] that will have the rule evaluated against each of its instances</param>
        /// <returns>An IEnumerable[T] containing only instances that satisfy the rule</returns>
        public IEnumerable<T> SatisfyingElementsFrom(IEnumerable<T> candidates)
        {
            return candidates.Where(_evalCompiled);
        }
    }
}
