require './node.rb'

class Stack
    attr_reader :limit
    attr_accessor :top_item, :size
    def initialize(limit=1000)
        @top_item = nil
        @size = 0
        @limit = limit
    end

    def push(value)
        if self.has_space()
            item = Node.new(value)
            item.next_node = @top_item
            @top_item = item
            @size += 1
            puts "Adding #{value} to the pizza stack!"
        else
            puts "No room for #{value} in stack."
        end
    end

    def pop()
        if !self.is_empty()
            item_to_remove = @top_item
            @top_item = item_to_remove.next_node
            @size -= 1
            puts "Delivering #{item_to_remove.value}"
            return item_to_remove.value
        end
        puts "All out of pizza."
    end

    def peek()
        if !self.is_empty()
            return @top_item.value
        end
        puts "Nothing to see here!"
    end

    def has_space()
        @limit > @size
    end        

    def is_empty()
        @size == 0
    end
end