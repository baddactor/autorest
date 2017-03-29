/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

/**
 * @class
 * Initializes a new instance of the Widget class.
 * @constructor
 * @member {number} [integer]
 *
 * @member {string} [string]
 *
 */
class Widget {
  constructor() {
  }

  /**
   * Defines the metadata of Widget
   *
   * @returns {object} metadata of Widget
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'Widget',
      type: {
        name: 'Composite',
        className: 'Widget',
        modelProperties: {
          integer: {
            required: false,
            serializedName: 'integer',
            type: {
              name: 'Number'
            }
          },
          string: {
            required: false,
            serializedName: 'string',
            type: {
              name: 'String'
            }
          }
        }
      }
    };
  }
}

module.exports = Widget;
