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
 * Initializes a new instance of the DictionaryWrapper class.
 * @constructor
 * @member {object} [defaultProgram]
 *
 */
class DictionaryWrapper {
  constructor() {
  }

  /**
   * Defines the metadata of DictionaryWrapper
   *
   * @returns {object} metadata of DictionaryWrapper
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'dictionary-wrapper',
      type: {
        name: 'Composite',
        className: 'DictionaryWrapper',
        modelProperties: {
          defaultProgram: {
            required: false,
            serializedName: 'defaultProgram',
            type: {
              name: 'Dictionary',
              value: {
                  required: false,
                  serializedName: 'StringElementType',
                  type: {
                    name: 'String'
                  }
              }
            }
          }
        }
      }
    };
  }
}

module.exports = DictionaryWrapper;
